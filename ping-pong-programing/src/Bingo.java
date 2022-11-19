import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class Bingo {


    Random random = new Random();

    List<Integer> bingoCard = new ArrayList<>();
    List<Integer> bColumn = new ArrayList<>();
    List<Integer> iColumn = new ArrayList<>();
    List<Integer> nColumn = new ArrayList<>();
    List<Integer> gColumn = new ArrayList<>();
    List<Integer> oColumn = new ArrayList<>();
    List<Integer> pickedNumbers = new ArrayList<>();


    public void playBingo(List<Integer> bingoCard) {
        int numberCounter = 0;
        int nextNr = randomNumber();
        while (!bingoCard.isEmpty()) {
            while (pickedNumbers.contains(nextNr)) {
                nextNr = randomNumber();
            }
            pickedNumbers.add(nextNr);
            if (bingoCard.contains(nextNr)) {
                bingoCard.remove((Integer) nextNr);
            }
            numberCounter++;
        }
        System.out.println("==========================");
        System.out.println("BINGO!!! BINGO!!! BINGO!!!");
        System.out.println("==========================");

        System.out.println("Total numbers drawn: " + numberCounter);
        System.out.println("Drawn numbers: " + pickedNumbers);
    }

    private int randomNumber(){
        return random.nextInt(1,75);
    }

    public List<Integer> generateBingoCard() {
        columnB();
        columnI();
        columnN();
        columnG();
        columnO();

        return this.bingoCard;
    }

    public void printCard() {
        System.out.println("B | " + bColumn);
        System.out.println("I | " + iColumn);
        System.out.println("N | " + nColumn);
        System.out.println("G | " + gColumn);
        System.out.println("O | " + oColumn);
    }

    private void columnB() {
        int[] B = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
        columnNumbersPicker(B, bColumn);
    }

    private void columnI() {
        int[] I = {16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30};
        columnNumbersPicker(I, iColumn);
    }

    private void columnN() {
        int[] N = {31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45};
        columnNumbersPicker(N, nColumn);
    }

    private void columnG() {
        int[] G = {46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60};
        columnNumbersPicker(G, gColumn);
    }

    private void columnO() {
        int[] O = {61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75};
        columnNumbersPicker(O, oColumn);
    }

    public void columnNumbersPicker(int[] columnNumbers, List<Integer> globalColumn) {
        for (int i = 0; i < 5; i++) {
            int nextNumber = columnNumbers[random.nextInt(0, 14)];
            while (bingoCard.contains(nextNumber)) {
                nextNumber = columnNumbers[random.nextInt(0, 14)];
            }
            bingoCard.add(nextNumber);
            globalColumn.add(nextNumber);
        }
    }
}
