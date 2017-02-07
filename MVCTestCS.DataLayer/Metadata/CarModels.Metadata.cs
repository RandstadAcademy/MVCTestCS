using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTestCS.DataLayer
{
    [MetadataType(typeof(CarModelsMetadata))]
    public partial class CarModels
    {
        
        [Display(Name = "Descrizione estesa")]
        public string FullTitle
        {
            get {
                return String.Concat(this.Manifactures.Name ," ",this.ModelName);
            }
        }

        internal sealed partial class CarModelsMetadata
        {
            public int Id { get; set; }
            [Display(Name = "Modello")]
            [Required(ErrorMessage = "Stronzo il cognome lo devi mettere!")]
            public string ModelName { get; set; }
            public string Color { get; set; }
            public int Year { get; set; }
            [Range(0, Byte.MaxValue, ErrorMessage = "O ti hanno fottuto le porte o hai un autobus! ")]
            public byte CarDoor { get; set; }
            public Nullable<int> Km { get; set; }
            public bool IsUsed { get; set; }
            public int ManifactureId { get; set; }
        }

    }



}
