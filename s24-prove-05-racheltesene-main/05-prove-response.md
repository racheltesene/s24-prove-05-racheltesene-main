**CSE 212 – Programming with Data Structures**

**W05 Prove – Response Document**

------------------------------------------

_It is a violation of BYU-Idaho Honor Code to post or share this document with others or to post it online.  Storage into a personal and private repository (e.g. private GitHub repository, unshared Google Drive folder) is acceptable._

------------------------------------------

**Question 1:**  From Part 1, how did you answer the interview question for the Set Operations problem (should be no more than 30 seconds if spoken aloud)?

(For the intersection function, I'd just check each item in one set to see if it's in the other set, then add it to the result if it is. For the union function, I'd just combine both sets into a new one, making sure to avoid any duplicates.)

**Question 2:**  From Part 2, how did you answer the interview question for the Find Pairs problem (should be no more than 30 seconds if spoken aloud)?

(I'd approach it by using a dictionary to store the count of each number in one set, then iterate through the other set to see if there are any pairs. This approach has a time complexity of O(n), making it efficient for large sets.)

**Part 3 Question 1:**
(To efficiently find symmetric pairs of two-letter words in a list in O(n) time using a set, I'd employ a straightforward approach. First, I'd initialize an empty set to store processed words. Then, I'd iterate through each word in the list, checking if its reverse exists in the set of processed words. If found, it constitutes a symmetric pair, which I'd print. Each word encountered is added to the set. By traversing the list just once and with constant time lookups in the set, this method achieves O(n) time complexity.)

**Part 3 Question 2:**
(When it comes to analyzing the purpose, behavior, and performance of a set, it's crucial to delve into its intended function, how it operates in various scenarios, and how efficiently it achieves its objectives. By scrutinizing these aspects, we gain invaluable insights into optimization opportunities, potential improvements, and overall effectiveness. Understanding a set in this comprehensive manner enables us to make informed decisions, enhance its functionality, and maximize its impact.)

------------------------------------------

_Remember:  Make sure all of your changes are committed and pushed to the `main` branch of your_ **prove-05-[username]** _repository_

_Also, submit this document and a link to your repository in I-Learn_
