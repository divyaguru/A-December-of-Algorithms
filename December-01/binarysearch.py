#PROGRAM TO PERFORM BINARY SEARCH
noOfElements = input("Enter the number of terms and the elements: ")
list = []

for i in range(noOfElements):
    print("Element {x}: ").format(x=i)
    list.append(int(input()))
    
print(list)

    
#FUNCTION TO PERFORM BINARY SEARCH   
def binSearch(list):
    flag = 0
    key = input("Enter search element: ")
    list.sort()
    print(list)
    
    
    while(len(list)>0):
        n = len(list)
        
        if key == list[n/2]:
            flag = 1
            print("spot on!")
            break
            
        elif key != list[n/2]:
            if key>list[n/2]:
                list = list[(n/2)+1 : n]
                print("you're too high")
                i=0
            
            elif key<list[n/2]:
                list = list[0: (n/2)]
                print("you're too low")
                i=0
        
    if flag is 1:
        print("ELEMENT IS PRESENT!")
        
    else:
        print("ELEMENT IS ABSENT")
    
#FUNCTION CALL
binSearch(list)