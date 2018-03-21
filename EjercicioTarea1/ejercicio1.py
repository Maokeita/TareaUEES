try:
    print("Ejercicio para calcular la velocidad")
    print("Desea Iniciar? Ingrese Si para continuar, No o cualquier cosa para salir")
    inc = input()
    while inc == "Si":
        print("Ingresa la distancia en Km")
        distancia = float(input())
        print("Ingresa el tiempo en horas")
        tiempo = float(input())
        velocidad = round(distancia/tiempo, 2)
        print(f"La velcidad es: {velocidad} Km/h")
        print("Desea Continuar?")
        inc = input()
    print("Gracias por participar")
    salir = input()
except ValueError:
    print("Porfavor solo ingrese numeros!!! No letras No espacios en blanco")
    SALIDA = input()
