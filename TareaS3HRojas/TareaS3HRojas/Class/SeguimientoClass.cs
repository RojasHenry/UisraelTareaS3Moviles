using System;
namespace TareaS2HRojas.Class
{
    public class SeguimientoClass
    {
        public string nota1 { get; set; }
        public string nota2 { get; set; }
        public string examen1 { get; set; }
        public string examen2 { get; set; }
        public string notaParcial1
        {
            get
            {
                return string.Format("{0:F2}", Convert.ToDouble(nota1) + Convert.ToDouble(examen1));
            }

            set
            {
                notaParcial1 = value;
            }
        }
        public string notaParcial2
        {
            get
            {
                return string.Format("{0:F2}", Convert.ToDouble(nota2) + Convert.ToDouble(examen2));
            }

            set
            {
                notaParcial2 = value;
            }
        }
        public string notaFinal
        {
            get
            {
                return string.Format("{0:F2}", Convert.ToDouble(notaParcial1) + Convert.ToDouble(notaParcial2));
            }
            set
            {
                notaParcial2 = value;
            }
        }
        public string estado
        {
            get => (Convert.ToDouble(notaFinal) >= 7) ? "Aprobado" : "Reprobado";
            set => estado = value;
        }
    }
}
