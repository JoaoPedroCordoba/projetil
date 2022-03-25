double angulo, velo0, xmax, hmax, g, rad;
g = 9.80665;


Console.WriteLine("Entre com a velocidade, em m/s..:");
velo0 = Convert.ToDouble(Console.ReadLine())!;

Console.WriteLine("Entre com o ângulo, em graus....:");
angulo = Convert.ToDouble(Console.ReadLine()!);

rad = angulo * (Math.PI / 180);

hmax = Math.Pow(velo0 * Math.Sin(rad),2) / (2*g);
xmax = Math.Pow(velo0,2) * (Math.Sin(2*rad)) / g;

Console.WriteLine($"Alcance........:{xmax:N2}m");
Console.WriteLine($"Altura máxima..:{hmax:N2}m");