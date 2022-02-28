/**
 * @param {string} path
 * @return {string}
 */
var simplifyPath = function(path) {
    path = path.replaceAll('//', '/')
    let pathes = path.split('/');
    let stack = []
    for(let i = 0; i < pathes.length; i ++){
        if(pathes[i].length > 0){
            let t = pathes[i];
            if(t == '.'){
                continue;
            }else if(t == '..'){
                stack.pop()
            }else{
                stack.push(pathes[i])
            }
        }
    }

    let finalStr = "/" + stack.join('/')
    return finalStr

};
