using System.Collections.Generic;

namespace TeamReflection.Enum
{
    public static class StoredProcedures
    {
        public enum Procedures
        {
            sp_LoginAccount,
            sp_RegisterAccount
        }

        public static Dictionary<Procedures, string> StoredProcedure = new Dictionary<Procedures, string>()
        {
            { Procedures.sp_LoginAccount, "sp_LoginAccount" },
            { Procedures.sp_RegisterAccount, "sp_RegisterAccount" }
        }; 
    }
}