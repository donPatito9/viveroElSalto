using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElSalto_NEGOCIO.Planta
{
    public class Planta : ObservableObject, IPersistente
    {
        public int PlantaId { get; set; }
        private string _nombreComun;
        private string _nombreCientifico;
        private string _tipoPlanta;
        private string _descripcion;
        private int _tiempoRiego;
        private int _cantidadAgua;
        private string _epoca;
        public bool EsVenenosa { get; set; }
        public bool EsAutoctona { get; set; }
    
        //validaNombreComun

        [Required(ErrorMessage = "Nombre Comun es obligatorio")]
        [MaxLength(100, ErrorMessage = "Nombre Comun demasiado largo")]
        [MinLength(10, ErrorMessage = "Nombre Comun no tiene el largo adecuado")]
        public string NombreComun
        {
            get { return _nombreComun; }
            set
            {
                ValidateProperty(value, "NombreComun");
                OnPropertyChanged(ref _nombreComun, value);
            }
        }

        //ValidaNombreCientifico

        [Required(ErrorMessage = "Nombre Cientifico es obligatorio")]
        [MaxLength(150, ErrorMessage = "Nombre Cientifico no tiene el largo adecuado")]
        [MinLength(10, ErrorMessage = "Nombre Cientifico Muy corto")]
        public string NombreCientifico
        {
            get { return _nombreCientifico; }
            set
            {
                ValidateProperty(value, "NombreCientifico");
                OnPropertyChanged(ref _nombreCientifico, value);
            }
        }

        //validaTipoPlanta

        [Required(ErrorMessage = "El Tipo de Planta es obligatorio")]
        // [StringLength(25, MinimumLength = 16, ErrorMessage = "")]
        public string TipoPlanta
        {
            get { return _tipoPlanta; }
            set
            {
                ValidateProperty(value, "TipoPlanta");
                OnPropertyChanged(ref _tipoPlanta, value);
            }
        }

        //validaDescripcion no es obligatorio puede ir vacio

        //[Required(ErrorMessage = "Descripcion es obligatorio")] puede estar vacio
        [StringLength(100, MinimumLength = 0, ErrorMessage = "Sin Informacion")]
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                ValidateProperty(value, "Descripcion");
                OnPropertyChanged(ref _descripcion, value);
            }
        }

        //ValidaTiempoRiego
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int TiempoRiego
        {
            get { return _tiempoRiego; }
            set
            {
                ValidateProperty(value, "TiempoRiego");
                OnPropertyChanged(ref _tiempoRiego, value);
            }
        }

        //ValidacantidadeAgua
        [Required(ErrorMessage = "El campo es obligatorio")]
        public int CantidadAgua
        {
            get { return _cantidadAgua; }
            set
            {
                //ValidateProperty(value, "CantidadDeAgua");
                OnPropertyChanged(ref _cantidadAgua, value);
            }
        }

        //ValidaEpoca

        [Required(ErrorMessage = "El campo es obligatorio")]
        //[StringLength(10, MinimumLength = 0, ErrorMessage = "largo adecuado")]
        public string Epoca
        {
            get { return _epoca; }
            set
            {
               // ValidateProperty(value, "Epoca");
                OnPropertyChanged(ref _epoca, value);
            }
        }

        // name hace referencia al nombre de la propiedad que se esta evaluando
        private void ValidateProperty<T>(T value, string name)
        {
            Validator.ValidateProperty(value, new ValidationContext(this, null, null)
            {
                MemberName = name //name//= propertyName
            });

        }


        public bool Create()
        {
            try
            {
                CommonBC.PlantaModelo.spPlantaSave(

                    // PlantaId,
                    Helpers.AES_Helper.EncryptString(this.NombreComun),
                    Helpers.AES_Helper.EncryptString(this.NombreCientifico),
                    TipoPlanta,
                    Helpers.AES_Helper.EncryptString(this.Descripcion),
                    TiempoRiego,
                    CantidadAgua,
                    Epoca,
                    EsVenenosa,
                    EsAutoctona
                );

                CommonBC.PlantaModelo.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool Read(int PlantaId)
        {
            try
            {
                ElSalto_DALC.vwPlanta planta = CommonBC.PlantaModelo.vwPlanta.First(p => p.PlantaId == PlantaId);

                PlantaId = planta.PlantaId;

                this.NombreComun = Helpers.AES_Helper.DecryptString(planta.NombreComun);

                this.NombreCientifico = Helpers.AES_Helper.DecryptString(planta.NombreCientifico);

                this.TipoPlanta = TipoPlanta;

                this.Descripcion = Helpers.AES_Helper.DecryptString(planta.Descripcion);

                this.TiempoRiego = planta.TiempoRiego;
                this.CantidadAgua = planta.CantidadAgua;
                this.Epoca = planta.Epoca;
                this.EsVenenosa = EsVenenosa;
                this.EsAutoctona = EsAutoctona;

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Update()
        {
            try
            {
                CommonBC.PlantaModelo.spPlantaUpdateById(

                PlantaId,
                Helpers.AES_Helper.EncryptString(this.NombreComun),
                Helpers.AES_Helper.EncryptString(this.NombreCientifico),
                TipoPlanta,
                Helpers.AES_Helper.EncryptString(this.Descripcion),
                TiempoRiego,
                CantidadAgua,
                Epoca,
                EsVenenosa,
                EsAutoctona);

                CommonBC.PlantaModelo.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public bool Delete(int EquipoId)
        {
            try
            {
                CommonBC.PlantaModelo.spPlantaDeleteById(PlantaId);
                CommonBC.PlantaModelo.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }

}