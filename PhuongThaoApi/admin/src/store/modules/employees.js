import axios from "axios";

export default{
    namespace: true,
    state:{
        employees:[
            
        ]
    },
    getters:{
        getEmployee(state){
            return state.employees
        }
    },
    mutations:{
        setEmployee: (state,employees)=>{
            state.employees = employees
        }
    },
    actions:{
        loadEmployee: ({commit}) =>{
            axios.get("http://localhost:8080/api/user/employee")
            .then(res => commit("setEmployee",res.data))
        }
    }
}