public static class Coin {

    private static Random rnd = new Random();
    public static string Flip() {
        return rnd.NextInt64() % 2 == 0 ? "Heads" : "Tails";
    }
}