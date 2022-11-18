public class Main {
    public static void main(String[] args) {

//        Bingo bingo = new Bingo();
//
//        List<Integer> bingoCard = bingo.generateBingoCard();
//        bingo.printCard();
//
//       bingo.playBingo(bingoCard);


        FizzBuzz fizzBuzz = new FizzBuzz();


        for (int i = 0; i< 100; i++){
            System.out.println(fizzBuzz.fizzBuzz(i, 2, 7, 15));
        }
    }
}