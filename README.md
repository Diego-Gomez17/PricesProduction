# PricesProduction

Es una aplicacion de escritorio que permite sacar el costo de la horas de trabajo de un freelance 
de cualquier academia. para ello sigue las siguiente estroctura de precio

### Insumo (I)
se deben añadir los costos de los elementos necesario para la produccion
el insumo se multiplica por 2 debido a que se projectan posibles errores en la produccion
o materiales dañados de fabrica

## Valor Hora (VH)
es el costo personal del valor unitario de cada hora de trabajo
este valor se multiplicara en conjunto de otros

## Cantidad de horas (CH)
basicamente la cantidad horas que se planean trabajar para terminar el producto

## Otros costos (OC)
se añaden costos adicionales que no se manifiestan en el insumo como gastos
personales de traslado o gestiones externas

## Calulos internos
se calcula el 30% del costo hora (VH * CH) para obtener asi costos internos
como por ejemplo: internet, luz, agua u otros elementos no cuantificables
Adicionalmente se agrega un sobrecargo del 45% para poder tener holgura al 
momento de dar descuentos sin perder ganancias de produccion
por ende la formula seria la siguiente 

T = (I * 2)+(VH +(VH * 0.30)* CH) + OC

F = T + (T * 45)
