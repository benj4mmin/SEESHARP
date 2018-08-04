def main():
    endProgram = 'no'
    choice=0
    totalBudget=5000
    while endProgram == 'no':
        print
        print 'Budgeting Tool'
        print 'Menu Selections: '
        print '1-Add an Expense: '
        print '2-Remove an Expense: '
        print '3-Add Revenue: '
        print '4-Remove Revenue: '
        print '5-Check Budget Balance: '
        print '6-Exit'  
        print
        userInput = raw_input('enter your selection: ')
        if userInput != "":
            choice=int(userInput)
            if choice == 1:
                    totalBudget = addExpense(totalBudget)
            elif choice == 2:
                    totalBudget = removeExpense(totalBudget)
            elif choice == 3:
                    totalBudget = addRevenue(totalBudget)
            elif choice == 4:
                    totalBudget = removeRevenue(totalBudget)
            elif choice == 5:
                 print 'Your balance is',totalBudget
            elif choice == 6:
                 endProgram = 'yes'
                 print 'Ending program, Goodbye'
            else:
                print 'Invalid selection, please try again'
         

#Add Expense Module       
def addExpense(totalBudget):
    #totalBudget is 5000
    expense = input ('Enter your expense amount: $')
    monthly = input ('How many times per month: ')
    totalExpense = expense * monthly
    if totalExpense >= totalBudget:
        print ('The expenses was rejected because the budget exceeded.'),totalBudget
    else:
        totalBudget= totalBudget - totalExpense
        print ('The expenses was accepted, your remaining budget is: $'),totalBudget
    choice=int(raw_input('enter your selection: '))
    return totalBudget
 
     
#Remove Expense Module 
def removeExpense(totalBudget):
    expense = int(raw_input('Enter the amount to remove:'))
    monthly = int(raw_input('Enter the frequency of the Expense Removal per month:'))
    totalExpense = expense * monthly
    if totalExpense <= (totalBudget):
        totalBudget = totalBudget + totalEpense
        checkBudget(totalBudget)
         
    else:
        print '*ERROR* re-check the amounts entered'
        return totalBudget

#Add Revenue Module 
def addRevenue (totalBudget):
    income = int(raw_input('Enter the amount of additional income:'))
    totalBudget = totalBudget + income
    checkBudget(totalBudget)
    return totalBudget

#Remove Revenue Module 
def removeRevenue (totalBudget):
    lostIncome = int(raw_input('Enter the amount of income to be removed:'))
    totalBudget = totalBudget - lostIncome
    checkBudget(totalBudget)
    return totalBudget

#Checks budget for previous functions
def checkBudget(totalBudget):
    if totalBudget >= (0):
        print 'The remaining budget is: ', totalBudget
    else:
        print 'You have exceeded the monthly budget'
        print 'Re-evaluate your expenses and balance the budget'
        print 'Current balance:', totalBudget

 
main()
