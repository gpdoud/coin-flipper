// See https://aka.ms/new-console-template for more information

var maxHeads = 0;
var heads = 0;

const long count = 1000000000;
var flip = string.Empty;
long idx = 0;
while(true) {
    flip = Coin.Flip();
    switch(flip) {
        case "Heads":
            heads++;
            //System.Console.Write(".");
            break;
        case "Tails":
            if(heads > maxHeads) {
                maxHeads = heads;
                System.Console.WriteLine($"{maxHeads}");
            }
            heads = 0;
            break;
    }
    if(maxHeads >= 35) break;
}
System.Console.WriteLine($"MaxHeads: {maxHeads}");