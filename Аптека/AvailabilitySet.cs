//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Аптека
{
    using System;
    using System.Collections.Generic;
    
    public partial class AvailabilitySet
    {
        public int ID { get; set; }
        public int IdPharmacy { get; set; }
        public int IdMedicine { get; set; }
        public int Amount { get; set; }
        public int Price { get; set; }
    
        public virtual MedicineSet MedicineSet { get; set; }
        public virtual PharmacySet PharmacySet { get; set; }
    }
}
