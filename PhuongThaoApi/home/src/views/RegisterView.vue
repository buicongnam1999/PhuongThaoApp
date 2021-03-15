<template>
    <div class="register">
        <div class="register-title">
            Tạo mới tài khoản
        </div>
        <register-form />
    </div>
</template>

<script>
import RegisterForm from '../components/register/RegisterForm.vue'
export default {
    data() {
        return {
            
        }
    },
    components:{
        RegisterForm

    }
}
</script>

<style>
.register-title{
    font-size: 28px;
    text-transform: inherit;
    font-weight: 700;
    font-family: Arial;
    margin-left: 30px;
}
</style>