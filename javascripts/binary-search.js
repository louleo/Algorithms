function sort(list){

}


function binarySearchInternal(low, high, element, list){
    mid = (high + low) / 2;
    mid = Math.floor(mid);
    guess = list[mid];
    if (element > guess){
        low = mid + 1;
    }else if(element < guess){
        high = mid - 1;
    }else{
        return mid;
    }
    return binarySearchInternal(low, high, element, list);
}

function binarySearchInternalWhile(element, list){
    list = list.sort();
    low = 0;
    high = list.length - 1;
    while(low < high){
        mid = (low + high)/2
        mid = Math.floor(mid);
        guess = list[mid];
        if (guess > element){
            high = mid - 1;
        }else if(guess < element){
            low = mid + 1;
        }else{
            return mid;
        }
    }
    return null;
}

function binarySearch(element, list){
    list = list.sort();
    return binarySearchInternal(0, list.length - 1, element, list);
}


function test(){
    arr = [1,5,7,11,3,55,2,35];
    console.log(binarySearch(3, arr) ===arr.indexOf(3));
    console.log(binarySearchInternalWhile(3, arr) === arr.indexOf(3));
}


test();
