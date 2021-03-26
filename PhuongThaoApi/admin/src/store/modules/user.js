import axios from "axios";

export default {
    namespaced: true,
    state: {
        use:[

        ]
    },
    getters: {
        
    },
    mutations: {
        
        
    },
    actions: {
        async getUserLogin({commit},name,pass){
            await axios.get("https://localhost:44344/api/user/"+name+"&&"+pass)
            .then(res => commit("",res.data))
        }
    }
}