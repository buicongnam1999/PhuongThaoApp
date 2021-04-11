import axios from "axios";

export default {
    namespaced: true,
    state: {
        orders: [
            {
                id: 1
            }
        ],
        orderFirst:[

        ]
    },
    getters: {
        getOrders(state){
            return state.orders;
        },
        getOrdersFirst(state){
            return state.orderFirst
        }
    },
    mutations: {
        setOrders: (state, orders) => {
            state.orders = orders;
        },
        setOrdersFirst:(state,orders) =>{
            state.orderFirst = orders
        }
    },
    actions: {
        loadData: ({commit}) =>{
            axios.get("https://localhost:44344/api/order").then(res => commit("setOrders", res.data));
        }
    }
}