import axios from "axios";
import Vue from "vue";

export default {
    namespaced: true,
    state: {
        employees: [
            {
            }
        ],
        employee:{
            "u_id": 0,
            "user_fullname": '',
            "user_gender": 1,
            "user_phone": '',
            "user_email": '',
            "user_address": '',
            "u_name": '',
            "user_pass": 'abc@1234',
            "user_type": 2,
            "user_status": 1,
            "user_img": ""
        },
    },
    getters: {
        getEmployees(state){
            return state.employees;
        },
        getEmployeeEdit(state){
            return state.employee;
        }
    },
    mutations: {
        setEmployees: (state, employees) => {
            state.employees = employees;
        },
        addEmployee: (state,employee) =>{
            state.employees.push(employee)
            Vue.set(state.employees,state.employees.length - 1,employee)
        },
        setEmployeeById(state,employee){
            state.employee = employee
        },
        setEmployeeBy(state,employee){
            state.employee = employee
        }
    },
    actions: {
        async loadData({commit}){
            axios.get("https://localhost:44344/api/user/employee").then(res => commit("setEmployees", res.data));
        },
        async addEmployee({commit,dispatch}, employee){
            await axios.post("https://localhost:44344/api/user",employee)
            .then(commit("addEmployee",employee))
            .finally(
                dispatch("loadData")
            )
        },
        async getEmployeeById({commit},id){
            await axios.get("https://localhost:44344/api/user/"+id)
            .then( res =>commit("setEmployeeById", res.data))
        },
    }
}