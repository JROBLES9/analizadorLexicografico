-- Palabras reservadas
local and_var = true and false
local varrr = true;
local a_A_a = false;
local break_var = false
local do_var = true
local else_var = false
local elseif_var = true
local end_var = false
local false_var = true
local for_var = 123
local function_var = function(x) return x * x end
local if_var = false
local in_var = "in identifier"
local local_var = 3.14
local nil_var = nil
local not_var = true
local or_var = false    
local repeat_var = 42
local return_var = "return value"
local then_var = true
local true_var = false
local until_var = true
local while_var = "while loop"

for index, value in ipairs(t) do
    break
    break 
break 
break
break dslasjdf
end

-- Identificadores
local identifier_1 = "first identifier"
local identifier_2 = 987
local identifier_3 = 3.14159

-- Números enteros y flotantes
local integer_number = 12345
local float_number = 3.14159

-- Valores booleanos
local boolean_true = true
local boolean_false = false

-- Cadenas
local string_1 = "Hello, world!"
local string_2 = "Lua programming"
local string_3 = "12345"

-- Imprimir algunos valores
print("and_var:", and_var)
print("break_var:", break_var)
print("do_var:", do_var)
print("else_var:", else_var)
print("elseif_var:", elseif_var)
print("end_var:", end_var)
print("false_var:", false_var)
print("for_var:", for_var)
print("function_var:", function_var(5))
print("if_var:", if_var)
print("in_var:", in_var)
print("local_var:", local_var)
print("nil_var:", nil_var)
print("not_var:", not not_var)
print("or_var:", or_var)
print("repeat_var:", repeat_var)
print("return_var:", return_var)
print("then_var:", then_var)
print("true_var:", true_var)
print("until_var:", until_var)
print("while_var:", while_var)
print("identifier_1:", identifier_1)
print("identifier_2:", identifier_2)
print("identifier_3:", identifier_3)
print("integer_number:", integer_number)
print("float_number:", float_number)
print("boolean_true:", boolean_true)
print("boolean_false:", boolean_false)
print("string_1:", string_1)
print("string_2:", string_2)
print("string_3:", string_3)

-- Declaración de variables
local numero = 42
local cadena = "Hola, mundo!"

-- Función para sumar dos números
function sumar(a, b)
    return a + b
end

-- Función para imprimir un mensaje
function imprimirMensaje(mensaje)
    print(mensaje)
end

-- Bucle for
for i = 1, 10 do
    numero = numero + i
end

-- Tabla (arreglo asociativo)
local persona = {
    nombre = "Juan",
    edad = 30,
    ciudad = "Ciudad de Ejemplo"
}

-- Condicionales
if numero > 50 then
    imprimirMensaje("El número es mayor que 50.")
elseif numero < 50 then
    imprimirMensaje("El número es menor que 50.")
else
    imprimirMensaje("El número es igual a 50.")
end

-- Función principal
function main()
    imprimirMensaje("Este es un programa Lua de ejemplo.")
    imprimirMensaje("El resultado de sumar 5 y 7 es: " .. sumar(5, 7))
    imprimirMensaje("Hola, " .. persona.nombre .. " desde " .. persona.ciudad)
end

-- Llamada a la función principal
main()
main()
main()