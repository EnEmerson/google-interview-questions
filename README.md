# google-interview-questions
This is a repo containing my solutions to released practice questions given by Google to their interviewees.

---

## Can you find a pair of numbers whose sum equals the target number?

### Prompt:

Given a list containing integers in order, for example: `[1, 3, 5, 8, 12, 13, 22]` and a target number, for example `16`. Can you find a pair of numbers whose sum equals the target number?

[Original Reddit post that inspired the creation of this rep](https://old.reddit.com/r/learnprogramming/comments/9vp1vv/an_interesting_problem_from_a_job_interview_at/)

**I will be attempting to solve this question using `/u/SirSassyCat`'s suggestion in the reddit post.**

* Iterate through the array
* Subtract each value from the target number
* Check if the remainder is present in the array

[Comprehensive discussion of solutions by Santiago Basulto](https://notebooks.ai/santiagobasulto/1-interview-questions-sum-of-numbers-google-9f26238f)

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