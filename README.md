# google-interview-questions
This is a repo containing my solutions to released practice questions given by google to their interviewees.

---

## Can you find a pair of numbers whose sum equals the target number?

[Matching pairs question](https://old.reddit.com/r/learnprogramming/comments/9vp1vv/an_interesting_problem_from_a_job_interview_at/)

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
        
        if((listOfInts.size() % 2) != 0){			//list is odd length
            
            int mid = (int)(listOfInts.size()/2);
            median = listOfInts.get(mid);
        }
        else {							//list is even length	
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