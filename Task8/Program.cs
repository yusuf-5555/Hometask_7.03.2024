var gauge = new Gauge(4);
gauge.Enhance();
gauge.Enhance();
gauge.Decrease();
System.Console.WriteLine(gauge.Full());
