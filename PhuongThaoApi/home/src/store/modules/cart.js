import axios from "axios";

export default {
    namespaced: true,
    state: {
        cart: [
            {

            }
        ]
    },
    getters: {
        getCarts(state){
            return state.cart;
        }
    },
    mutations: {
        setCarts: (state, cart) => {
            state.cart = cart;
        }
    },
    actions: {
        loadData: ({commit}) =>{
            axios.get("https://localhost:44344/api/cart/1").then(res => commit("setCarts", res.data));
        }
    }
}