# google-interview-questions
This is a repo containing my solutions to released practice questions given by Google to their interviewees.

---

## Can you find a pair of numbers whose sum equals the target number?

### Prompt:

Given a list containing integers in order, for example: `[1, 3, 5, 8, 12, 13, 22]` and a target number, for example `16`. Can you find a pair of numbers whose sum equals the target number?

[Original Reddit post that inspired the creation of this rep](https://old.reddit.com/r/learnprogramming/comments/9vp1vv/an_interesting_problem_from_a_job_interview_at/)

**I will be attempting to solve this question using `/u/SirSassyCat`'s suggestion in the reddit post.**

1. Iterate through the array
2. Subtract each value from the target number
3. Check if the remainder is present in the array

#### Code block for the sum check logic:

```C#
private void button2_Click(object sender, EventArgs e)
{
	/* Algorithm:
	* 1. Iterate through the array
	* 2. Subtract current value from the target number
	* 3. Check if remainder exists in array
	*/

	// check if target number data is valid
	int targetNumber = 0;
	bool goodData = Int32.TryParse(testBox.Text, out targetNumber);
	if (goodData && (MIN_VAL <= targetNumber))
	{
		// set target number from the test box input
                targetNumber = int.Parse(testBox.Text);
                // 1. begin iteration thru numbers array
                for (int num = 0; num < numbers.Length; num++)
                {
			int currentNumber = numbers[num];
                    	// 2. subtract current value from the target number
                    	int remainder = targetNumber - currentNumber;
                    	// 3a. iterate through rest of array
                    	for (int checkNum = num + 1; checkNum < numbers.Length; checkNum++)
                    	{
                        	int nextNumber = numbers[checkNum];
                        	// 3b. check if remainder is in the array
                        	if (remainder == nextNumber)
                        	{
                            		// found a match!
                            		MessageBox.Show("Match found! \r\n'"
                                		+ currentNumber + "' at index: [" + num + "]"
                                		+ "\r\n AND \r\n'"
                                		+ nextNumber + "' at index: [" + checkNum + "]\r\n"
                                		+ " add up to the target number: '" + targetNumber + "'");
                            		Application.Exit();
                        	}
			}
		}
                // none of the numbers match
		MessageBox.Show("No two integers in this list add up to the target number.");
	}
	else
	{
                MessageBox.Show("Bad input data");
	}
}
```
[My full solution here](https://github.com/EnEmerson/google-interview-questions/blob/master/pairing-numbers/pairingNumbers/pairingNumbers/Form1.cs)

[Comprehensive discussion of potential solutions by Santiago Basulto](https://notebooks.ai/santiagobasulto/1-interview-questions-sum-of-numbers-google-9f26238f)

---

## Build a system that inserts integers and returns the median of the collection.

### Integer Collection Prompt:

Build a system that has two methods: insertInt(int i) and getMedian(return median). Consider all edge cases and exceptions, use whatever language you're most comfortable with. Method insertInt(int i) adds an integer to a collection of your choosing and getMedian() returns the median of the collection of integers. You may use helper functions and make any assumptions that simplify the question.

My assumptions for this question: 

* Coded in Java
* The user only enters integers
* The getMedian() function can only be called after insertInt() so the list actually has items in it
* The median will be greater than 0
* A helper function sortList() may be called to order the array, highest to lowest

#### Code block for insertInt() function: 

```Java
public void insertInt(int parInt) {
        int intToInsert = parInt;
        listOfInts.add(intToInsert);
        sortArray();
    }
```

#### Code block for getMedian() function:

```Java
public double getMedian() {
        
        double median = 0;

        //list is odd length
        if((listOfInts.size() % 2) != 0){
            
            int mid = (int)(listOfInts.size()/2);
            median = listOfInts.get(mid);
        }

	//list is even length
        else {		
            int midHi, midLo;
            midHi = (int)(listOfInts.size()/2);
            midLo = (int)((listOfInts.size()/2) - 1);
            median = (listOfInts.get(midHi) + listOfInts.get(midLo)) / 2;
        }
        
        return median;
    }
```

[My full solution here](https://github.com/EnEmerson/google-interview-questions/blob/master/aitp-interview/src/IntegerCollection.java)

---