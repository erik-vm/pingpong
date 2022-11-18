public class FizzBuzz {

    public String fizzBuzz(int number, int fizzNr, int buzzNr, int popNr){
        StringBuilder str = new StringBuilder();

        if (number % fizzNr == 0){
            str.append("Fizz");
        }
        if (number % buzzNr == 0){
            str.append("Buzz");
        }
        if (number % popNr == 0){
            str.append("Pop");
        }
        if (str.isEmpty()){
            str.append(number);
        }
        return str.toString();
    }

}
