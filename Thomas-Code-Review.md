***First Impression***<br/>
Upon compilation, I found no major errors. One design change I would suggest is to make it so the user cannot change add or save records in Form1 because there is no way to enter data into the state's fields.
<br/><br/>
***Form1 code***<br/>
I found that the code for Form1 was well-documented. The code looks good, but I noticed that the LoadComboBox() method could be removed entirely if the combo box used data bound items.
<br/><br/>
***StateDetails code***<br/>
I found the code for StateDetails to be well-documented. The code for the form looks good. Good use of the filter property on the stateInfoBindingSource!
<br/><br/>
***Testing***<br/>
I found that in Form1, if the user selects a state from the combo box that is not the one selected by the navigation bar, then clicks one of the navigation buttons, the program will crash because it attempts to insert the state name selected by the combo box into the state selected by the navigation bar, causing a primary key constraint exception.<br/>
I encountered an error in Form1 where if the user adds a state and selects another state via the navigation bar, the program will crash because it attempts to insert a state into the state table with a null state name, leading to a primary key constraint exception. <br/>
In the StateDetails form, I am able to enter negative values into the population, median income, and percentage of computer jobs text boxes. I can also leave all text boxes blank except for the ones for population, median income, and percentage of computer jobs. This does not cause the program to crash when the table is saved due to the strings being empty and not null.
<br/><br/>
***Comparing Projects***<br/>
In this project, LINQ query syntax is used to interact with the data context. In my project, I used LINQ method syntax to work with the data context. There is no significant difference between the two besides the way it is written. I will continue to use LINQ extension methods in my programs.
