﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SelfhostClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://hehe", ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hehe/IService/AddOperation", ReplyAction="http://hehe/IService/AddOperationResponse")]
        double AddOperation(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hehe/IService/AddOperation", ReplyAction="http://hehe/IService/AddOperationResponse")]
        System.Threading.Tasks.Task<double> AddOperationAsync(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hehe/IService/SubOperation", ReplyAction="http://hehe/IService/SubOperationResponse")]
        double SubOperation(double num1, double num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://hehe/IService/SubOperation", ReplyAction="http://hehe/IService/SubOperationResponse")]
        System.Threading.Tasks.Task<double> SubOperationAsync(double num1, double num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : SelfhostClient.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<SelfhostClient.ServiceReference1.IService>, SelfhostClient.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double AddOperation(double num1, double num2) {
            return base.Channel.AddOperation(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> AddOperationAsync(double num1, double num2) {
            return base.Channel.AddOperationAsync(num1, num2);
        }
        
        public double SubOperation(double num1, double num2) {
            return base.Channel.SubOperation(num1, num2);
        }
        
        public System.Threading.Tasks.Task<double> SubOperationAsync(double num1, double num2) {
            return base.Channel.SubOperationAsync(num1, num2);
        }
    }
}
