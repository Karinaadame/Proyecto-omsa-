using System;
using Xunit; 
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    public class CafeMachineTests
    {
        [Fact]
        public void SeleccionarVaso_Pequeño_DeberíaReducirVasosPequeñosYReducirCafe()
        {
            var machine = new CafeMachine();
            var result = machine.SeleccionarVaso(VasoTamaño.Pequeño);
            Assert.Equal("Vaso pequeño seleccionado.", result);
        }

        [Fact]
        public void SeleccionarAzucar_SuficienteAzucar_DeberíaReducirAzucarDisponible()
        {
            var machine = new CafeMachine();
            var result = machine.SeleccionarAzucar(2);
            Assert.Equal("2 cucharadas de azúcar añadidas.", result);
        }

        [Fact]
        public void RecogerVaso_DeberíaDevolverMensajeDeExito()
        {
            var machine = new CafeMachine();
            var result = machine.RecogerVaso();
            Assert.Equal("Aquí tiene su café. ¡Disfrute!", result);
        }

        [Fact]
        public void SeleccionarVaso_NoHayVasos_DeberíaMostrarMensajeDeError()
        {
            var machine = new CafeMachine();
            for (int i = 0; i < 10; i++) // 10 vasos pequeños consumidos
            {
                machine.SeleccionarVaso(VasoTamaño.Pequeño);
            }
            var result = machine.SeleccionarVaso(VasoTamaño.Pequeño);
            Assert.Equal("No hay vasos pequeños.", result);
        }

        [Fact]
        public void SeleccionarAzucar_NoHayAzucar_DeberíaMostrarMensajeDeError()
        {
            var machine = new CafeMachine();
            for (int i = 0; i < 25; i++) // 25*2 cucharadas = 50 cucharadas de azúcar consumidas
            {
                machine.SeleccionarAzucar(2);
            }
            var result = machine.SeleccionarAzucar(1);
            Assert.Equal("No hay suficiente azúcar.", result);
        }
    }
}
