
## Sistema de Gestión comercial para local gastronómico. 

Sistema de Gestión de Base de Datos
Este proyecto consiste en el diseño, modelado e implementación de un sistema de base de datos relacional robusto desarrollado en SQL Server para la gestión integral de una rotisería.

El sistema está optimizado para administrar el ciclo completo de pedidos, control de insumos/ingredientes por producto, métodos de pago, seguimiento de entregas y roles de personal repartidor.

##🛠️ Tecnologías Utilizadas
Motor de BD: SQL Server

Herramientas de Gestión: SQL Server Management Studio (SSMS)

Lenguaje: T-SQL (DDL / DML)

##🚀 Características Principales del Modelo
Gestión de Menú y Recetario (Relación M:N):

Mapeo de productos y sus ingredientes correspondientes mediante tablas compuestas e intermedias.

Clasificación jerárquica de artículos por categorías.

Control de Pedidos y Detalle (Master-Detail):

Registro centralizado de órdenes (Orders) asociadas a sus ítems (Order Items).

Vinculación dinámica con clientes y métodos de pago.

Logística y Entregas:

Módulo de envíos (Shipments) vinculado al personal de delivery para el seguimiento de entregas a domicilio.
