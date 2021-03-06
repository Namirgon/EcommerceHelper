﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceHelper.BLL.SWTarjeta {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SWTarjeta.IServicioPago")]
    public interface IServicioPago {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPago/ProcesarPago", ReplyAction="http://tempuri.org/IServicioPago/ProcesarPagoResponse")]
        bool ProcesarPago(string elNroTarjeta, decimal elMonto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicioPago/ProcesarPago", ReplyAction="http://tempuri.org/IServicioPago/ProcesarPagoResponse")]
        System.Threading.Tasks.Task<bool> ProcesarPagoAsync(string elNroTarjeta, decimal elMonto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicioPagoChannel : EcommerceHelper.BLL.SWTarjeta.IServicioPago, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicioPagoClient : System.ServiceModel.ClientBase<EcommerceHelper.BLL.SWTarjeta.IServicioPago>, EcommerceHelper.BLL.SWTarjeta.IServicioPago {
        
        public ServicioPagoClient() {
        }
        
        public ServicioPagoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicioPagoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPagoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicioPagoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool ProcesarPago(string elNroTarjeta, decimal elMonto) {
            return base.Channel.ProcesarPago(elNroTarjeta, elMonto);
        }
        
        public System.Threading.Tasks.Task<bool> ProcesarPagoAsync(string elNroTarjeta, decimal elMonto) {
            return base.Channel.ProcesarPagoAsync(elNroTarjeta, elMonto);
        }
    }
}
