// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shipper.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Northwind.Mvc.Sqlite {
  public static partial class Shipr
  {
    static readonly string __ServiceName = "shipr.Shipr";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Northwind.Mvc.Sqlite.ShipperRequest> __Marshaller_shipr_ShipperRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Northwind.Mvc.Sqlite.ShipperRequest.Parser));
    static readonly grpc::Marshaller<global::Northwind.Mvc.Sqlite.ShipperReply> __Marshaller_shipr_ShipperReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Northwind.Mvc.Sqlite.ShipperReply.Parser));

    static readonly grpc::Method<global::Northwind.Mvc.Sqlite.ShipperRequest, global::Northwind.Mvc.Sqlite.ShipperReply> __Method_GetShipper = new grpc::Method<global::Northwind.Mvc.Sqlite.ShipperRequest, global::Northwind.Mvc.Sqlite.ShipperReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetShipper",
        __Marshaller_shipr_ShipperRequest,
        __Marshaller_shipr_ShipperReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Northwind.Mvc.Sqlite.ShipperReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for Shipr</summary>
    public partial class ShiprClient : grpc::ClientBase<ShiprClient>
    {
      /// <summary>Creates a new client for Shipr</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ShiprClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Shipr that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ShiprClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ShiprClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ShiprClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Northwind.Mvc.Sqlite.ShipperReply GetShipper(global::Northwind.Mvc.Sqlite.ShipperRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetShipper(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Northwind.Mvc.Sqlite.ShipperReply GetShipper(global::Northwind.Mvc.Sqlite.ShipperRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetShipper, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Northwind.Mvc.Sqlite.ShipperReply> GetShipperAsync(global::Northwind.Mvc.Sqlite.ShipperRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetShipperAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Northwind.Mvc.Sqlite.ShipperReply> GetShipperAsync(global::Northwind.Mvc.Sqlite.ShipperRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetShipper, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ShiprClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ShiprClient(configuration);
      }
    }

  }
}
#endregion
