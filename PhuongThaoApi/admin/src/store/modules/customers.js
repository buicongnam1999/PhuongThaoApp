import axios from "axios";

export default {
    namespaced: true,
    state: {
        customers: [
            {
                id: 1
            }
        ]
    },
    getters: {
        getCustomers(state){
            return state.customers;
        }
    },
    mutations: {
        setCustomers: (state, customers) => {
            state.customers = customers;
        }
    },
    actions: {
        loadData: ({commit}) =>{
            axios.get("https://localhost:44344/api/user/customer").then(res => commit("setCustomers", res.data));
        },
        async addCustomer({commit,dispatch}, customer){
            await axios.post("https://localhost:44344/api/user",customer)
            .then(commit("addCustomer",customer))
            .finally(
                dispatch("loadData")
            )
        },
    }
}