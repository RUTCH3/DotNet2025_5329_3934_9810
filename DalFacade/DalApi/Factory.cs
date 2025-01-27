using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DalApi;

public static class Factory
{

    internal static string s_dalName;
    internal static Dictionary<string, string> s_dalPackages;

    public static IDAL Get
    {
        get
        {
            string dalType = s_dalName ??
                throw new DalConfigException($"Dal name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ??
                throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");
            try { Assembly.Load(dal ?? throw new DalConfigException($"Package {dal.Package} is null")); }
            catch (Exception ex) { throw new DalConfigException($"Failed to load {dal.Package}.dll package", ex); }
            Type type = Type.GetType($"Dal.{dal}, {dal}") ??
                     throw new DalConfigException($"Class Dal.{dal} was not found in {dal.Package}.dll");
            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDal ??
                throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
        }
    }
}
