//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace yycms.entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class yy_Page_Build_Config
    {
        public long ID { get; set; }
        public long PageTypeID { get; set; }
        public long PageID { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int BuildType { get; set; }
        public string DataTypeIDs { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}