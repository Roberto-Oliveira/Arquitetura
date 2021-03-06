﻿using System;

#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PortalDAO
{
    using System.Data.Linq.Mapping;


    [global::System.Data.Linq.Mapping.DatabaseAttribute(Name="bd_Defensoria_Transparencia")]
	public partial class PortalDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public PortalDataContext() : 
				base(global::PortalDAO.Properties.Settings.Default.bd_Defensoria_TransparenciaConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public PortalDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PortalDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PortalDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public PortalDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<vw_folha_pagamento> vw_folha_pagamentos
		{
			get
			{
				return this.GetTable<vw_folha_pagamento>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.vw_folha_pagamento")]
    [Serializable]
	public partial class vw_folha_pagamento
	{
		
		private string _Matrícula;
		
		private string _Nome;
		
		private string _Cargo;
		
		private decimal _Vencimento;
		
		private decimal _Subsidio;
		
		private decimal _Vantagens_Pessoais;
		
		private decimal _Vantagens_Cargo;
		
		private decimal @__1_3_Férias;
		
		private decimal @__13__Salário;
		
		private decimal _Total_Créditos;
		
		private decimal _Previdência;
		
		private decimal _Imposto_de_Renda;
		
		private decimal _Total_Descontos;
		
		private decimal _Rendimento_Líquido;
		
		private decimal _Indenizações;
		
		public vw_folha_pagamento()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Matrícula", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Matrícula
		{
			get
			{
				return this._Matrícula;
			}
			set
			{
				if ((this._Matrícula != value))
				{
					this._Matrícula = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nome", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Nome
		{
			get
			{
				return this._Nome;
			}
			set
			{
				if ((this._Nome != value))
				{
					this._Nome = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cargo", DbType="VarChar(255) NOT NULL", CanBeNull=false)]
		public string Cargo
		{
			get
			{
				return this._Cargo;
			}
			set
			{
				if ((this._Cargo != value))
				{
					this._Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Vencimento", DbType="Decimal(38,2) NOT NULL")]
		public decimal Vencimento
		{
			get
			{
				return this._Vencimento;
			}
			set
			{
				if ((this._Vencimento != value))
				{
					this._Vencimento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Subsidio", DbType="Decimal(38,2) NOT NULL")]
		public decimal Subsidio
		{
			get
			{
				return this._Subsidio;
			}
			set
			{
				if ((this._Subsidio != value))
				{
					this._Subsidio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Vantagens Pessoais]", Storage="_Vantagens_Pessoais", DbType="Decimal(38,2) NOT NULL")]
		public decimal Vantagens_Pessoais
		{
			get
			{
				return this._Vantagens_Pessoais;
			}
			set
			{
				if ((this._Vantagens_Pessoais != value))
				{
					this._Vantagens_Pessoais = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Vantagens Cargo]", Storage="_Vantagens_Cargo", DbType="Decimal(38,2) NOT NULL")]
		public decimal Vantagens_Cargo
		{
			get
			{
				return this._Vantagens_Cargo;
			}
			set
			{
				if ((this._Vantagens_Cargo != value))
				{
					this._Vantagens_Cargo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[1/3 Férias]", Storage="__1_3_Férias", DbType="Decimal(38,2) NOT NULL")]
		public decimal _1_3_Férias
		{
			get
			{
				return this.@__1_3_Férias;
			}
			set
			{
				if ((this.@__1_3_Férias != value))
				{
					this.@__1_3_Férias = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[13° Salário]", Storage="__13__Salário", DbType="Decimal(38,2) NOT NULL")]
		public decimal _13__Salário
		{
			get
			{
				return this.@__13__Salário;
			}
			set
			{
				if ((this.@__13__Salário != value))
				{
					this.@__13__Salário = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Créditos]", Storage="_Total_Créditos", DbType="Decimal(38,2) NOT NULL")]
		public decimal Total_Créditos
		{
			get
			{
				return this._Total_Créditos;
			}
			set
			{
				if ((this._Total_Créditos != value))
				{
					this._Total_Créditos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Previdência", DbType="Decimal(38,2) NOT NULL")]
		public decimal Previdência
		{
			get
			{
				return this._Previdência;
			}
			set
			{
				if ((this._Previdência != value))
				{
					this._Previdência = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Imposto de Renda]", Storage="_Imposto_de_Renda", DbType="Decimal(38,2) NOT NULL")]
		public decimal Imposto_de_Renda
		{
			get
			{
				return this._Imposto_de_Renda;
			}
			set
			{
				if ((this._Imposto_de_Renda != value))
				{
					this._Imposto_de_Renda = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Total Descontos]", Storage="_Total_Descontos", DbType="Decimal(38,2) NOT NULL")]
		public decimal Total_Descontos
		{
			get
			{
				return this._Total_Descontos;
			}
			set
			{
				if ((this._Total_Descontos != value))
				{
					this._Total_Descontos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Rendimento Líquido]", Storage="_Rendimento_Líquido", DbType="Decimal(38,2) NOT NULL")]
		public decimal Rendimento_Líquido
		{
			get
			{
				return this._Rendimento_Líquido;
			}
			set
			{
				if ((this._Rendimento_Líquido != value))
				{
					this._Rendimento_Líquido = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Indenizações", DbType="Decimal(38,2) NOT NULL")]
		public decimal Indenizações
		{
			get
			{
				return this._Indenizações;
			}
			set
			{
				if ((this._Indenizações != value))
				{
					this._Indenizações = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
