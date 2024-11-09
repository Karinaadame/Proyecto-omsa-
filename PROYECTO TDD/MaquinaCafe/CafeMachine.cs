using System;

namespace MaquinaCafe
{
    public enum VasoTamaño { Pequeño, Mediano, Grande }

    public class CafeMachine
    {
        private int _cafeDisponible = 100;
        private int _azucarDisponible = 50;
        private int _vasosPequeños = 10;
        private int _vasosMedianos = 10;
        private int _vasosGrandes = 10;

        public string SeleccionarVaso(VasoTamaño tamaño)
        {
            switch (tamaño)
            {
                case VasoTamaño.Pequeño:
                    if (_vasosPequeños > 0)
                    {
                        _vasosPequeños--;
                        if (_cafeDisponible >= 3)
                        {
                            _cafeDisponible -= 3;
                            return "Vaso pequeño seleccionado.";
                        }
                        return "No hay suficiente café.";
                    }
                    return "No hay vasos pequeños.";
                case VasoTamaño.Mediano:
                    if (_vasosMedianos > 0)
                    {
                        _vasosMedianos--;
                        if (_cafeDisponible >= 5)
                        {
                            _cafeDisponible -= 5;
                            return "Vaso mediano seleccionado.";
                        }
                        return "No hay suficiente café.";
                    }
                    return "No hay vasos medianos.";
                case VasoTamaño.Grande:
                    if (_vasosGrandes > 0)
                    {
                        _vasosGrandes--;
                        if (_cafeDisponible >= 7)
                        {
                            _cafeDisponible -= 7;
                            return "Vaso grande seleccionado.";
                        }
                        return "No hay suficiente café.";
                    }
                    return "No hay vasos grandes.";
                default:
                    return "Tamaño de vaso no válido.";
            }
        }

        public string SeleccionarAzucar(int cucharadas)
        {
            if (_azucarDisponible >= cucharadas)
            {
                _azucarDisponible -= cucharadas;
                return $"{cucharadas} cucharadas de azúcar añadidas.";
            }
            return "No hay suficiente azúcar.";
        }

        public string RecogerVaso()
        {
            return "Aquí tiene su café. ¡Disfrute!";
        }
    }
}
