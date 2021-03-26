import Vue from "vue";
import Vuex from "vuex";
import foods from "./modules/foods";
import cart from "./modules/cart"
Vue.use(Vuex);

export default new Vuex.Store({
    state:{

    },
    getters:{},
    actions:{},
    modules: {
        foods,
        cart
    }
})