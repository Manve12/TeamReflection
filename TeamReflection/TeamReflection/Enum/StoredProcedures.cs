using System.Collections.Generic;

namespace TeamReflection.Enum
{
    public static class StoredProcedures
    {
        public enum Procedures
        {
            /// <summary>
            /// @Username NVARCHAR(50)
            /// @Password NVARCHAR(50)
            /// </summary>
            /// <Returns>
            /// Account from database where username matches
            /// </Returns>
            sp_LoginAccount,

            /// <summary>
            /// @Username NVARCHAR(50),
            /// @Fullname NVARCHAR(50),
            /// @Password NVARCHAR(50),
            /// @Email NVARCHAR(50),
            /// @PhoneNumber NVARCHAR(50),
            /// @BillingFirstLine NVARCHAR(50),
            /// @BillingPostCode NVARCHAR(50),
            /// @BillingCounty NVARCHAR(50)
            /// </summary>
            /// <Returns>
            /// Account from database where username matches after the initial creation
            /// </Returns>
            sp_RegisterAccount,

            /// <summary>
            /// To be implemented
            /// </summary>
            sp_AddCargo,

            /// <summary>
            /// To be implemented
            /// </summary>
            sp_AddWarehouseByAccount,

            /// <summary>
            /// To be implemented
            /// </summary>
            sp_EditCargo,

            /// <summary>
            /// @Username NVARCHAR(50)
            /// </summary>
            /// <Returns>
            /// WarehouseId INT
            /// </Returns>
            sp_GetWarehouseByAccount
        }

        public static Dictionary<Procedures, string> StoredProcedure = new Dictionary<Procedures, string>()
        {
            { Procedures.sp_LoginAccount, "sp_LoginAccount" },
            { Procedures.sp_RegisterAccount, "sp_RegisterAccount" },
            { Procedures.sp_AddCargo, "sp_AddCargo" },
            { Procedures.sp_AddWarehouseByAccount, "sp_AddWarehouseByAccount" },
            { Procedures.sp_EditCargo, "sp_EditCargo" },
            { Procedures.sp_GetWarehouseByAccount, "sp_GetWarehouseByAccount" },
        }; 
    }
}