//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace podgotovka
{
    using System;
    using System.Collections.Generic;
    
    public partial class Товар
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Товар()
        {
            this.Склад = new HashSet<Склад>();
            this.Товар_В_Заказе = new HashSet<Товар_В_Заказе>();
        }
    
        public int Код { get; set; }
        public string Наименование { get; set; }
        public Nullable<int> Продавец { get; set; }
        public string Описание { get; set; }
        public string Картинка { get; set; }
        public Nullable<double> Цена { get; set; }
        public Nullable<int> Скидка { get; set; }
    
        public virtual Продавец Продавец1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Склад> Склад { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Товар_В_Заказе> Товар_В_Заказе { get; set; }
    }
}
