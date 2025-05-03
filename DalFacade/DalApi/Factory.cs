using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static DalApi.DalConfig;

namespace DalApi;

public static class Factory
{
    public static IDAL Get
    {
        get
        {
            string dalType = s_dalName ??
                throw new DalConfigException($"Dal name is not extracted from the configuration");
            string dal = s_dalPackages[dalType] ??
                throw new DalConfigException($"Package for {dalType} is not found in packages list in dal-config.xml");
            if (dal != null) Console.WriteLine(dal);
            try { Assembly.Load(dal ?? throw new DalConfigException($"Package {dal} is null")); }
            catch (Exception ex)
            {
                //Console.WriteLine(Path.GetFullPath(@"..\xml\dal-config.xml"));
                throw new DalConfigException($"Failed to load {dal}.dll package", ex);
            }
            Type type = Type.GetType($"Dal.{dal}, {dal}") ??
                     throw new DalConfigException($"Class Dal.{dal} was not found in {dal}.dll");
            return type.GetProperty("Instance", BindingFlags.Public | BindingFlags.Static)?.GetValue(null) as IDAL ??
                throw new DalConfigException($"Class {dal} is not a singleton or wrong property name for Instance");
        }
    }
}
