## Un banco tiene 3 clientes que pueden hacer depósitos y extracciones. También el banco requiere que al final del día calcule la cantidad de dinero que hay depositada.

### La Solución tendrá el siguiente esquema: Debemos definir los atributos y los métodos de cada clase:

* Cliente
    - atributos
        - nombre
        - monto
    - métodos
        - constructor
        - Depositar
        - Extraer
        - RetornarMonto

* Banco
    - atributos
        - 3 Cliente (3 objetos de la clase Cliente)
    - métodos
        - constructor
        - Operar
        - DepositosTotales
