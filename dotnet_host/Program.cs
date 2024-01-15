using Wasmtime;

var fuel = ulong.Parse(args[0]);

using var engine = new Engine(new Config().WithFuelConsumption(true));
using var module = Module.FromFile(engine, "rust_sample.wasm");

using var linker = new Linker(engine);
using var store = new Store(engine);
store.Fuel = fuel;

var instance = linker.Instantiate(store, module);
var run = instance.GetFunction<int>("get_answer");

try
{
   var result = run!();
   Console.WriteLine($"The answer is {result}.");

   Console.WriteLine($"Fuel: {store.Fuel}⛽");
}
catch (TrapException e)
{
    Console.WriteLine($"Ran out of fuel⛽: {Environment.NewLine} {e.Message}");
}