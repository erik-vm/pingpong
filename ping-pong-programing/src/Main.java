import java.util.List;

public class Main {
    public static void main(String[] args) {

        Bingo bingo = new Bingo();

        List<Integer> bingoCard = bingo.generateBingoCard();
        bingo.printCard();

        bingo.playBingo(bingoCard);
    }
}