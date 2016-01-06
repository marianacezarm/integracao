/**
 * Autogenerated by Thrift Compiler (0.9.2)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esus.cds.transport.generated.thrift.atividadeindividual
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class OutrosSiaThrift : TBase
  {
    private string _codigoExame;
    private List<string> _solicitadoAvaliado;

    public string CodigoExame
    {
      get
      {
        return _codigoExame;
      }
      set
      {
        __isset.codigoExame = true;
        this._codigoExame = value;
      }
    }

    public List<string> SolicitadoAvaliado
    {
      get
      {
        return _solicitadoAvaliado;
      }
      set
      {
        __isset.solicitadoAvaliado = true;
        this._solicitadoAvaliado = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool codigoExame;
      public bool solicitadoAvaliado;
    }

    public OutrosSiaThrift() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.String) {
              CodigoExame = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                SolicitadoAvaliado = new List<string>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  string _elem2;
                  _elem2 = iprot.ReadString();
                  SolicitadoAvaliado.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("OutrosSiaThrift");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (CodigoExame != null && __isset.codigoExame) {
        field.Name = "codigoExame";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(CodigoExame);
        oprot.WriteFieldEnd();
      }
      if (SolicitadoAvaliado != null && __isset.solicitadoAvaliado) {
        field.Name = "solicitadoAvaliado";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, SolicitadoAvaliado.Count));
          foreach (string _iter3 in SolicitadoAvaliado)
          {
            oprot.WriteString(_iter3);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("OutrosSiaThrift(");
      bool __first = true;
      if (CodigoExame != null && __isset.codigoExame) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CodigoExame: ");
        __sb.Append(CodigoExame);
      }
      if (SolicitadoAvaliado != null && __isset.solicitadoAvaliado) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("SolicitadoAvaliado: ");
        __sb.Append(SolicitadoAvaliado);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}