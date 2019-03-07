import java.util.ArrayList;

public class IntegerCollection {

	ArrayList<Integer> listOfInts = new ArrayList<Integer>();
	
	public void insertInt(int parInt) {
		int intToInsert = parInt;
		listOfInts.add(intToInsert);
		sortArray();
	}
	
	public void sortArray() {
		//this is a helper function, pretend it sorts the array.
	}
	
	public double getMedian() {
		
		double median = 0;
		
		if((listOfInts.size() % 2) != 0){
			
			int mid = (int)(listOfInts.size()/2);
			median = listOfInts.get(mid);
		}
		else {
			int midHi, midLo;
			midHi = (int)(listOfInts.size()/2);
			midLo = (int)((listOfInts.size()/2) - 1);
			median = (listOfInts.get(midHi) + listOfInts.get(midLo)) / 2;
		}
		
		return median;
	}
}
