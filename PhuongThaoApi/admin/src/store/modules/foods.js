import axios from "axios";

export default {
    namespaced: true,
    state: {
        foods: [
            {
                id: 1
            }
        ]
    },
    getters: {
        getFoods(state){
            return state.foods;
        }
    },
    mutations: {
        setFoods: (state, foods) => {
            state.foods = foods;
        }
    },
    actions: {
        loadData: ({commit}) =>{
            axios.get("http://localhost:8080/api/food").then(res => commit("setFoods", res.data));
        }
    }
}