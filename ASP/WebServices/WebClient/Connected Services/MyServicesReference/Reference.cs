//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.MyServicesReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyServicesReference.MyServicesSoap")]
    public interface MyServicesSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        WebClient.MyServicesReference.HelloWorldResponse HelloWorld(WebClient.MyServicesReference.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.MyServicesReference.HelloWorldResponse> HelloWorldAsync(WebClient.MyServicesReference.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name str from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        WebClient.MyServicesReference.MessageResponse Message(WebClient.MyServicesReference.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.MyServicesReference.MessageResponse> MessageAsync(WebClient.MyServicesReference.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Squareroot", ReplyAction="*")]
        float Squareroot(float f);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Squareroot", ReplyAction="*")]
        System.Threading.Tasks.Task<float> SquarerootAsync(float f);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.MyServicesReference.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WebClient.MyServicesReference.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.MyServicesReference.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WebClient.MyServicesReference.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Message", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.MyServicesReference.MessageRequestBody Body;
        
        public MessageRequest() {
        }
        
        public MessageRequest(WebClient.MyServicesReference.MessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string str;
        
        public MessageRequestBody() {
        }
        
        public MessageRequestBody(string str) {
            this.str = str;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.MyServicesReference.MessageResponseBody Body;
        
        public MessageResponse() {
        }
        
        public MessageResponse(WebClient.MyServicesReference.MessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MessageResult;
        
        public MessageResponseBody() {
        }
        
        public MessageResponseBody(string MessageResult) {
            this.MessageResult = MessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyServicesSoapChannel : WebClient.MyServicesReference.MyServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyServicesSoapClient : System.ServiceModel.ClientBase<WebClient.MyServicesReference.MyServicesSoap>, WebClient.MyServicesReference.MyServicesSoap {
        
        public MyServicesSoapClient() {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.MyServicesReference.HelloWorldResponse WebClient.MyServicesReference.MyServicesSoap.HelloWorld(WebClient.MyServicesReference.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WebClient.MyServicesReference.HelloWorldRequest inValue = new WebClient.MyServicesReference.HelloWorldRequest();
            inValue.Body = new WebClient.MyServicesReference.HelloWorldRequestBody();
            WebClient.MyServicesReference.HelloWorldResponse retVal = ((WebClient.MyServicesReference.MyServicesSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.MyServicesReference.HelloWorldResponse> WebClient.MyServicesReference.MyServicesSoap.HelloWorldAsync(WebClient.MyServicesReference.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.MyServicesReference.HelloWorldResponse> HelloWorldAsync() {
            WebClient.MyServicesReference.HelloWorldRequest inValue = new WebClient.MyServicesReference.HelloWorldRequest();
            inValue.Body = new WebClient.MyServicesReference.HelloWorldRequestBody();
            return ((WebClient.MyServicesReference.MyServicesSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.MyServicesReference.MessageResponse WebClient.MyServicesReference.MyServicesSoap.Message(WebClient.MyServicesReference.MessageRequest request) {
            return base.Channel.Message(request);
        }
        
        public string Message(string str) {
            WebClient.MyServicesReference.MessageRequest inValue = new WebClient.MyServicesReference.MessageRequest();
            inValue.Body = new WebClient.MyServicesReference.MessageRequestBody();
            inValue.Body.str = str;
            WebClient.MyServicesReference.MessageResponse retVal = ((WebClient.MyServicesReference.MyServicesSoap)(this)).Message(inValue);
            return retVal.Body.MessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.MyServicesReference.MessageResponse> WebClient.MyServicesReference.MyServicesSoap.MessageAsync(WebClient.MyServicesReference.MessageRequest request) {
            return base.Channel.MessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.MyServicesReference.MessageResponse> MessageAsync(string str) {
            WebClient.MyServicesReference.MessageRequest inValue = new WebClient.MyServicesReference.MessageRequest();
            inValue.Body = new WebClient.MyServicesReference.MessageRequestBody();
            inValue.Body.str = str;
            return ((WebClient.MyServicesReference.MyServicesSoap)(this)).MessageAsync(inValue);
        }
        
        public float Squareroot(float f) {
            return base.Channel.Squareroot(f);
        }
        
        public System.Threading.Tasks.Task<float> SquarerootAsync(float f) {
            return base.Channel.SquarerootAsync(f);
        }
    }
}
