<template>
    <div class="header">
        <div class="header-title">
            <slot></slot>
        </div>
        <button-add />
    </div>
</template>
<script>
import ButtonAdd from './ButtonAdd.vue'
export default {
    components:{
        ButtonAdd
    }
}
</script>

<style scoped>
.header{
    display: flex;
    margin-top: 20px;
    margin-left: 20px;
}
.header-title{
    width: 95%;
    font-size: 23px;
    font-weight: bold;
}
.header-function{
    display: flex;
    margin-top: 20px;
    justify-content: space-between;
}
</style>