# Prototipo Funcional de la Jaguar Gym App

para darle un mejor aspecto a los formularios de WinForms
se hizo uso de [Guna.UI2](https://www.nuget.org/packages/Guna.UI2.WinForms)


a continuación las distintas pantallas/forms

---

### Creación de Cuenta

---

### Inicio de Sesión

---
### Escaneo de Cédula o CIF

---

### Ingreso de Pago

---
### Agregar Miembro

---


### Pantalla de Estadísticas
**[Demo](https://www.youtube.com/watch?v=tRr9cSgII9Q)**


utiliza el [LiveCharts para WinForms](https://www.nuget.org/packages/LiveCharts.WinForms)

#### Gráficos

##### Pagos
1. Ingresos por mes
2. Pagos por conceptos

##### Miembros
1. Membresías porcentaje vigentes, expiradas
2. Miembros porcentaje internos, externos
3. Miembros por facultad

##### Entradas
1. Entradas por hora
2. Entradas por día 

#### Datos, Lógica

[Modelo](https://github.com/hbodan/JaguarGymApp_Preview/blob/a0a6bddac3bfd5c66bf707150c6e1bbd328d7641/estadisticasForm/EstructuraModelo.cs)

[PoblarModelo](https://github.com/hbodan/JaguarGymApp_Preview/blob/a0a6bddac3bfd5c66bf707150c6e1bbd328d7641/estadisticasForm/PoblarModelo.cs), para efectos de demostrar, se encarga de poblar dicho modelo sintéticamente

[LogicaEstadistica](https://github.com/hbodan/JaguarGymApp_Preview/blob/a0a6bddac3bfd5c66bf707150c6e1bbd328d7641/estadisticasForm/LogicaEstadistica.cs) realiza las operaciones para manipular los datos de manera que valgan la pena y sean válidos para LiveChart.

 
