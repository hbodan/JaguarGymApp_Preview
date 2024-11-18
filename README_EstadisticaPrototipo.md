estoy utilizando el paquete NuGet de LiveCharts para WinForms
https://www.nuget.org/packages/LiveCharts.WinForms

---

siguiendo un diccionario de datos:

## Pagos
gráfico de líneas de ingresos por mes
gráfico de pastel de concepto de pago

## Miembros
gráfico de pastel de membresías activas/vencidas
" " internos/exernos
gráfico de barras por facultad

## Entradas
gráfico de barra agrupando las entradas en intervalos, para entradas por horas en el día, 
por días en la semana

---

## Prototipo

utiliza este 
![Modelo](https://github.com/user-attachments/assets/78f34318-f8a0-4d73-a829-ab4272c0e69b)

la clase en PoblarModelo.cs se encarga de poblar dicho modelo sintéticamente
la clase en LogicaEstadistica.cs realiza las operaciones para obtener los datos a mostrar

y gracias a WinForms y LiveCharts, con cada cambio se muestran los gráficos anteriormente mencionados, actualizados.
 
