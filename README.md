# CS440
Coding project

There are 3 factors that interact with our application: Sensors, Laboratory User and Public User

For Sensor input, out application has set up a MOCK Sensor Input. The data passes from sensor to controller(HomeTrialController) to view(Sensor Interface). View Validates. If Validation successful, then data passes from view to controller to database(insert).

For Laboratory User, our application has set up a MOCK Value retrival from database. Data passes from database to controller(HomeTrialController) to view(Laboratory User). View validates. If validation successfull, then data passes from view to controller to database(update).
            
For Public User, our application has set up a MOCK Value retrival from database. Data passes from database to controller(HomeTrialController) to view(Public User).
