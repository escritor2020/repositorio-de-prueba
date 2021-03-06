USE [clientes]
GO
/****** Object:  Table [dbo].[clientes]    Script Date: 10/14/2020 19:30:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[clientes](
	[Id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NULL,
	[direccion] [varchar](30) NULL,
	[telefono] [varchar](30) NULL,
	[valor_inicial] [nvarchar](50) NULL,
	[numero_de_cuenta] [nvarchar](50) NULL,
	[saldo] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
