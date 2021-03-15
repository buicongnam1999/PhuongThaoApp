<template>
    <div class="login">
        <div class="login-title">
            Log in to your account
        </div>
        <login-form />
    </div>
</template>

<script>
import LoginForm from '../components/login/LoginForm.vue'
export default {
    data() {
        return {
            MessageAccount: ''
        }
    },
    components:{
        LoginForm
    }
        
}
</script>

<style scoped>
.login{
    margin-top: 20px;
}
.login-title{
    font-size: 28px;
    text-transform: inherit;
    font-weight: 700;
    font-family: Arial;
    margin-left: 30px;
}

</style>