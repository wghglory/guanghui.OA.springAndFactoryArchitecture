//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Guanghui.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class R_User_ActionInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ActionInfoId { get; set; }
        public bool IsPass { get; set; }
    
        public virtual ActionInfo ActionInfo { get; set; }
        public virtual User User { get; set; }
    }
}
