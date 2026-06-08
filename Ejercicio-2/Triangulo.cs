using System;
public class Triangulo
    {   // esto es un atributo privado de la clase Triangulo
     private float _base, altura, lado1, lado2, lado3;

            public Triangulo(float baseTri, float altura, float l1, float l2, float l3)
            {   // Constructor para inicializar los atributos
                _base = baseTri;
                this.altura = altura;
                lado1 = l1;
                lado2 = l2;
                lado3 = l3;
            }

    // los Getters y Setters para acceder y modificar los atributos privados
    public float GetBase() => _base;
        public void SetBase(float valor) => _base = valor;

        public float GetAltura() => altura;
        public void SetAltura(float valor) => altura = valor;

        public float GetLado1() => lado1;
        public void SetLado1(float valor) => lado1 = valor;

        public float GetLado2() => lado2;
        public void SetLado2(float valor) => lado2 = valor;

        public float GetLado3() => lado3;
        public void SetLado3(float valor) => lado3 = valor;

    // Métodos donde se realizan los cálculos para el área, perímetro y verificación de triángulo equilátero
    public float CalcularArea() => (_base * altura) / 2;
        public float CalcularPerimetro() => lado1 + lado2 + lado3;
        public bool EsEquilatero() => lado1 == lado2 && lado2 == lado3;
    }
