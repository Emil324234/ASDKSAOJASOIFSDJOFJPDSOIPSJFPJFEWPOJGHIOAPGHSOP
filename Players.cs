//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prct1labEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Players
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Players()
        {
            this.Weapons = new HashSet<Weapons>();
        }
    
        public int Player_ID { get; set; }
        public string PlayerName { get; set; }
        public int PlayerLevel { get; set; }
        public string PlayerClass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Weapons> Weapons { get; set; }
    }
}
