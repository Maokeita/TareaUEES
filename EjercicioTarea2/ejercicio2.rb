class Ejercicio2
  def initialize()
  end
  def solucion(numero1)
    puts "la suma de los valores es", numero1 / 9.8
  end
end
puts "\t Ejercicio 2"
puts "Desea Iniciar(Ingrese un 1 si desea Iniciar o cualquier numero si desea salir)"
respuesta = gets.chomp.to_i
while respuesta == 1
  puts "Ingresa la fuerza en Newton(kg. m/s2)"
  numero1 = gets.chomp.to_f
  objeto = Ejercicio2.new
  objeto.solucion(numero1)
  puts "Desea Continuar(Ingrese un 1 si desea Iniciar o cualquier numero si desea salir)"
  respuesta = gets.chomp.to_i
end
puts "\t Gracias por Participar"
gets()
